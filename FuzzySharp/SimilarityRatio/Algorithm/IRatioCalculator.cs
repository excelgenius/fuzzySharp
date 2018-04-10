﻿using FuzzySharp.PreProcess;

namespace FuzzySharp.SimilarityRatio
{
    public interface IRatioCalculator
    {
        int Calculate(string input1, string input2);
        int Calculate(string input1, string input2, IStringPreprocessor preprocessor);
    }
}