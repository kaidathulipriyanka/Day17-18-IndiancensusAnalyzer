using System;
using System.Collections.Generic;
using System.Text;
using static IndianCensusAnalyzer.CensusAnalyser;

namespace IndianCensusAnalyzer
{
    public class CensusAnalyserBase
    {
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath,
            string dataHeaders)
        {
            dataMap = new CsvAdaptorFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
