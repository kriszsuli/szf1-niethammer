using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Text.Encodings.Web;

namespace src
{
    public partial class MainForm : Form
    {
        // Kiválasztott képek fájlneveinek listája
        private List<string> selectedImages = new List<string>();
        // Betöltött képek tárolása fájlnév-Image párokban
        private Dictionary<string, Image> images = new Dictionary<string, Image>();

        public MainForm()
        {
            InitializeComponent();
            RenderHtml(); // HTML előnézet inicializálása (leírás részen)
        }

        #region event handlers
        // Mappaválasztó eseménykezelő: képek betöltése ListView-ba
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // UI komponensek és adatstruktúrák resetelése
                listView1.Items.Clear();
                imageList1.Images.Clear();
                listView1.LargeImageList = imageList1;
                listView1.View = View.LargeIcon;
                images.Clear();
                selectedImages.Clear();
                fileNameLabel.Text = "";
                directoryLabel.Text = "";
                pictureBox1.Image = null;
                UpdateCounter();

                directoryLabel.Text = dialog.SelectedPath;
                // Képfájlok listázása és validálás
                List<string> fileList = Directory.EnumerateFiles(dialog.SelectedPath).Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("jpeg") || file.ToLower().EndsWith("png")).ToList();
                
                // Hibakezelés
                if (fileList.Count > 1000)
                {
                    MessageBox.Show("Ebben a mappában túl sok kép van!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (fileList.Count == 0)
                {
                    MessageBox.Show("Ebben a mappában nincs kép!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Töltőcsík
                progressBar.Value = 0;
                progressBar.Maximum = fileList.Count;
                progressBar.Visible = true;

                // Képek betöltése
                foreach (string imagePath in fileList)
                {
                    string fileName = imagePath.Substring(dialog.SelectedPath.Length + 1);
                    int index = fileList.IndexOf(imagePath);
                    progressBar.Value = index; // Töltőcsík frissítése
                    try
                    {
                        Image image = Image.FromFile(imagePath);
                        imageList1.Images.Add(image);
                        images.Add(fileName, image);
                        listView1.Items.Add(new ListViewItem($"{fileName}", index));
                    }
                    catch (Exception ex)
                    {
                        //Hibakezelés
                        MessageBox.Show($"Nem lehetett betölteni a(z) {fileName} fájlt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                progressBar.Visible = false;
            }
        }

        // Ha kijelölésre kerül egy kép, ez lefut
        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool justChecked = !listView1.Items[e.Index].Checked;
            string fileName = listView1.Items[e.Index].Text;
            if (justChecked)
            {
                selectedImages.Add(fileName);
            }
            else
            {
                selectedImages.Remove(fileName);
            }
            UpdateCounter();
        }

        // "Nagyító" funkció féleség
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                pictureBox1.Image = images[listView1.SelectedItems[0].Text];
                fileNameLabel.Text = listView1.SelectedItems[0].Text;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            string localDirectory = Environment.CurrentDirectory;
            DateTime dateTimeNow = DateTime.Now;
            DateTime selectedDate = monthCalendar1.SelectionStart;
            string folderName = $"{dateTimeNow.Year}__{PadNumber(dateTimeNow.Month)}__{PadNumber(dateTimeNow.Day)}_{PadNumber(dateTimeNow.Hour)}_{PadNumber(dateTimeNow.Minute)}_{PadNumber(dateTimeNow.Second)}_{RemoveAccentsAndSpaces(titleTextBox.Text).ToLower()}";
            string feltolteniPath = Path.Combine(localDirectory, "feltölteni");

            // Hibakezelés
            if (!Directory.Exists(feltolteniPath))
            {
                Directory.CreateDirectory(feltolteniPath);
                richTextBox2.Text += $"[{DateTime.UtcNow}] 'feltölteni' mappa létrehozva\n";
            }

            string folderPath = Path.Combine(feltolteniPath, folderName);
            Directory.CreateDirectory(folderPath);
            richTextBox2.Text += $"[{DateTime.UtcNow}] '{folderName}' mappa létrehozva\n";

            // Metadata fájlok
            File.WriteAllText(Path.Combine(folderPath, "leiras.txt"), HtmlEncoder.Default.Encode(richTextBox1.Text));
            richTextBox2.Text += $"[{DateTime.UtcNow}] 'leiras.txt' létrehozva\n";

            File.WriteAllText(Path.Combine(folderPath, "szerzo.txt"), HtmlEncoder.Default.Encode(writerTextBox.Text));
            richTextBox2.Text += $"[{DateTime.UtcNow}] 'szerzo.txt' létrehozva\n";

            File.WriteAllText(Path.Combine(folderPath, "foto.txt"), HtmlEncoder.Default.Encode(photographerTextBox.Text));
            richTextBox2.Text += $"[{DateTime.UtcNow}] 'foto.txt' létrehozva\n";

            File.WriteAllText(Path.Combine(folderPath, "datum.txt"), HtmlEncoder.Default.Encode($"{selectedDate.Year}.{PadNumber(selectedDate.Month)}.{PadNumber(selectedDate.Day)}"));
            richTextBox2.Text += $"[{DateTime.UtcNow}] 'datum.txt' létrehozva\n";

            File.WriteAllText(Path.Combine(folderPath, "cim.txt"), HtmlEncoder.Default.Encode(titleTextBox.Text));
            richTextBox2.Text += $"[{DateTime.UtcNow}] 'cim.txt' létrehozva\n";

            foreach (string selectedImage in selectedImages)
            {
                Image thumbnail = ResizeImage(selectedImage, (int)thumbnailWidth.Value, null);
                Image large = ResizeImage(selectedImage, (int)largeImgWidth.Value, watermarkTextbox.Text);

                richTextBox2.Text += $"[{DateTime.UtcNow}] '{selectedImage}' átalakítva\n";

                string thumbnailPath = Path.Combine(folderPath, $"th_{RemoveAccentsAndSpaces(Path.GetFileName(selectedImage))}");
                string largePath = Path.Combine(folderPath, RemoveAccentsAndSpaces(Path.GetFileName(selectedImage)));

                thumbnail.Save(thumbnailPath);
                large.Save(largePath);

                richTextBox2.Text += $"[{DateTime.UtcNow}] '{selectedImage}' lementve\n";
            }

            richTextBox2.Text += $"[{DateTime.UtcNow}] Kész\n";
        }
        #endregion

        #region helpers
        // Kijelölt kép számláló frissítése
        private void UpdateCounter()
        {
            int counter = selectedImages.Count;
            selectedImgsLabel.Text = $"Kijelölt képek száma: {counter.ToString()}";
        }

        // Ékezetek és szóközök eltávolítására használt funkció
        private string RemoveAccentsAndSpaces(string text)
        {
            text = text.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in text)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark && CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.SpaceSeparator)
                {
                    stringBuilder.Append(c);
                }
                else if (CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.SpaceSeparator)
                {
                    stringBuilder.Append("_");
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        // Képszerkesztésre használt funkció
        // Ez kezeli a vízjeleket is.
        private Image ResizeImage(string fileName, int maxWidth, string watermark)
        {
            Image image = images[fileName];
            int relativeHeight = (int)(image.Height * (maxWidth / (float)image.Width));
            Rectangle destRect = new Rectangle(0, 0, maxWidth, relativeHeight);
            Bitmap destImage = new Bitmap(maxWidth, relativeHeight);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            if (watermark != null)
            {
                using (Graphics graphics = Graphics.FromImage(destImage))
                {
                    Font font = new Font("Arial", 40, FontStyle.Bold, GraphicsUnit.Pixel);
                    Color textColor = Color.FromArgb(255, 255, 255, 255);
                    Color bgColor = Color.FromArgb(150, 128, 128, 128);

                    SolidBrush textBrush = new SolidBrush(textColor);
                    SolidBrush bgBrush = new SolidBrush(bgColor);

                    graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                    SizeF textSize = graphics.MeasureString(watermark, font);

                    float x = textSize.Width / 2 - 40;
                    float y = destImage.Height - textSize.Height - 20;

                    graphics.FillRectangle(bgBrush, x - 5, y - 5, textSize.Width + 10, textSize.Height + 10);

                    graphics.DrawString(watermark, font, textBrush, new PointF(x, y));
                }

            }

            return destImage;
        }

        private void RenderHtml()
        {
            webBrowser.DocumentText = $@"
                <meta charset=utf8>
                <h1>{titleTextBox.Text}</h1>
                <p>{richTextBox1.Text}</p>
                <p>Fényképezte: {photographerTextBox.Text}</p>
                <p>Szöveget írta: {writerTextBox.Text}</p>
            ";
        }
        private string PadNumber(int number)
        {
            if (number > 9) return number.ToString();
            return $"0{number.ToString()}";
        }
        #endregion

        #region cooldown
        // Visszaszámláló, hogy ne minden betűlenyomásnál frissüljön az oldal, mert
        // eléggé lelassítja a programot.
        System.Windows.Forms.Timer renderTimer = new System.Windows.Forms.Timer();
        private new void TextChanged(object sender, EventArgs e)
        {
            renderTimer.Interval = 1000;
            renderTimer.Enabled = true;
            renderTimer.Start();
            renderTimer.Tick += Tick;
        }

        private void Tick(object? sender, EventArgs e)
        {
            RenderHtml();
            renderTimer.Stop();
        }
        #endregion
    }
}