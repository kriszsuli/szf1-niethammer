string alap = "ChatGPT is based on particular GPT foundation models, namely GPT-4, GPT-4o and GPT-4o mini, that were fine-tuned to target conversational usage.[17] The fine-tuning process leveraged supervised learning and reinforcement learning from human feedback (RLHF).[18][19] Both approaches employed human trainers to improve model performance. In the case of supervised learning, the trainers played both sides: the user and the AI assistant. In the reinforcement learning stage, human trainers first ranked responses that the model had created in a previous conversation.[20] These rankings were used to createreward models that were used to fine-tune the model further by using several iterations of proximal policy optimization.[18][21]ChatGPT is based on particular GPT foundation models, namely GPT-4, GPT-4o and GPT-4o mini, that were fine-tuned to target conversational usage.[17] The fine-tuning process leveraged supervised learning and reinforcement learning from human feedback (RLHF).[18][19] Both approaches employed human trainers to improve model performance. In the case of supervised learning, the trainers played both sides: the user and the AI assistant. In the reinforcement learning stage, human trainers first ranked responses that the model had created in a previous conversation.[20] These rankings were used to createreward models that were used to fine-tune the model further by using several iterations of proximal policy optimization.[18][21]";
for (int i = 0; i < alap.Length; i++) {
    if(!(char.IsLetter(alap[i])) && !(char.IsNumber(alap[i])) && !(char.IsWhiteSpace(alap[i]))) {
        alap = alap.Replace($"{alap[i]}", "");
    }
}

string nincsSzokoz = alap.Replace(" ","");
Console.WriteLine(nincsSzokoz);
string[] tomb = alap.Split(" ");
Console.WriteLine($"Szavak száma: {tomb.Length}, Karakterek száma (szóközök nélkül): {nincsSzokoz.Length}");