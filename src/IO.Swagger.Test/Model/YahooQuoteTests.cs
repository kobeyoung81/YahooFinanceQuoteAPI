/* 
 * Yahoo Finance Quote API
 *
 * This is the API from yahoo finance to get quote for symbols.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: kobeyoung81@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing YahooQuote
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class YahooQuoteTests
    {
        // TODO uncomment below to declare an instance variable for YahooQuote
        //private YahooQuote instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of YahooQuote
            //instance = new YahooQuote();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of YahooQuote
        /// </summary>
        [Test]
        public void YahooQuoteInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" YahooQuote
            //Assert.IsInstanceOfType<YahooQuote> (instance, "variable 'instance' is a YahooQuote");
        }


        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }
        /// <summary>
        /// Test the property 'Region'
        /// </summary>
        [Test]
        public void RegionTest()
        {
            // TODO unit test for the property 'Region'
        }
        /// <summary>
        /// Test the property 'QuoteType'
        /// </summary>
        [Test]
        public void QuoteTypeTest()
        {
            // TODO unit test for the property 'QuoteType'
        }
        /// <summary>
        /// Test the property 'QuoteSourceName'
        /// </summary>
        [Test]
        public void QuoteSourceNameTest()
        {
            // TODO unit test for the property 'QuoteSourceName'
        }
        /// <summary>
        /// Test the property 'Currency'
        /// </summary>
        [Test]
        public void CurrencyTest()
        {
            // TODO unit test for the property 'Currency'
        }
        /// <summary>
        /// Test the property 'MarketState'
        /// </summary>
        [Test]
        public void MarketStateTest()
        {
            // TODO unit test for the property 'MarketState'
        }
        /// <summary>
        /// Test the property 'PriceHint'
        /// </summary>
        [Test]
        public void PriceHintTest()
        {
            // TODO unit test for the property 'PriceHint'
        }
        /// <summary>
        /// Test the property 'RegularMarketChangePercent'
        /// </summary>
        [Test]
        public void RegularMarketChangePercentTest()
        {
            // TODO unit test for the property 'RegularMarketChangePercent'
        }
        /// <summary>
        /// Test the property 'RegularMarketDayRange'
        /// </summary>
        [Test]
        public void RegularMarketDayRangeTest()
        {
            // TODO unit test for the property 'RegularMarketDayRange'
        }
        /// <summary>
        /// Test the property 'Bid'
        /// </summary>
        [Test]
        public void BidTest()
        {
            // TODO unit test for the property 'Bid'
        }
        /// <summary>
        /// Test the property 'RegularMarketPreviousClose'
        /// </summary>
        [Test]
        public void RegularMarketPreviousCloseTest()
        {
            // TODO unit test for the property 'RegularMarketPreviousClose'
        }
        /// <summary>
        /// Test the property 'RegularMarketPrice'
        /// </summary>
        [Test]
        public void RegularMarketPriceTest()
        {
            // TODO unit test for the property 'RegularMarketPrice'
        }
        /// <summary>
        /// Test the property 'RegularMarketTime'
        /// </summary>
        [Test]
        public void RegularMarketTimeTest()
        {
            // TODO unit test for the property 'RegularMarketTime'
        }
        /// <summary>
        /// Test the property 'RegularMarketChange'
        /// </summary>
        [Test]
        public void RegularMarketChangeTest()
        {
            // TODO unit test for the property 'RegularMarketChange'
        }
        /// <summary>
        /// Test the property 'RegularMarketOpen'
        /// </summary>
        [Test]
        public void RegularMarketOpenTest()
        {
            // TODO unit test for the property 'RegularMarketOpen'
        }
        /// <summary>
        /// Test the property 'RegularMarketDayHigh'
        /// </summary>
        [Test]
        public void RegularMarketDayHighTest()
        {
            // TODO unit test for the property 'RegularMarketDayHigh'
        }
        /// <summary>
        /// Test the property 'RegularMarketDayLow'
        /// </summary>
        [Test]
        public void RegularMarketDayLowTest()
        {
            // TODO unit test for the property 'RegularMarketDayLow'
        }
        /// <summary>
        /// Test the property 'RegularMarketVolume'
        /// </summary>
        [Test]
        public void RegularMarketVolumeTest()
        {
            // TODO unit test for the property 'RegularMarketVolume'
        }
        /// <summary>
        /// Test the property 'Exchange'
        /// </summary>
        [Test]
        public void ExchangeTest()
        {
            // TODO unit test for the property 'Exchange'
        }
        /// <summary>
        /// Test the property 'EpsTrailingTwelveMonths'
        /// </summary>
        [Test]
        public void EpsTrailingTwelveMonthsTest()
        {
            // TODO unit test for the property 'EpsTrailingTwelveMonths'
        }
        /// <summary>
        /// Test the property 'EpsForward'
        /// </summary>
        [Test]
        public void EpsForwardTest()
        {
            // TODO unit test for the property 'EpsForward'
        }
        /// <summary>
        /// Test the property 'SharesOutstanding'
        /// </summary>
        [Test]
        public void SharesOutstandingTest()
        {
            // TODO unit test for the property 'SharesOutstanding'
        }
        /// <summary>
        /// Test the property 'BookValue'
        /// </summary>
        [Test]
        public void BookValueTest()
        {
            // TODO unit test for the property 'BookValue'
        }
        /// <summary>
        /// Test the property 'FiftyDayAverage'
        /// </summary>
        [Test]
        public void FiftyDayAverageTest()
        {
            // TODO unit test for the property 'FiftyDayAverage'
        }
        /// <summary>
        /// Test the property 'FiftyDayAverageChange'
        /// </summary>
        [Test]
        public void FiftyDayAverageChangeTest()
        {
            // TODO unit test for the property 'FiftyDayAverageChange'
        }
        /// <summary>
        /// Test the property 'FiftyDayAverageChangePercent'
        /// </summary>
        [Test]
        public void FiftyDayAverageChangePercentTest()
        {
            // TODO unit test for the property 'FiftyDayAverageChangePercent'
        }
        /// <summary>
        /// Test the property 'TwoHundredDayAverage'
        /// </summary>
        [Test]
        public void TwoHundredDayAverageTest()
        {
            // TODO unit test for the property 'TwoHundredDayAverage'
        }
        /// <summary>
        /// Test the property 'TwoHundredDayAverageChange'
        /// </summary>
        [Test]
        public void TwoHundredDayAverageChangeTest()
        {
            // TODO unit test for the property 'TwoHundredDayAverageChange'
        }
        /// <summary>
        /// Test the property 'TwoHundredDayAverageChangePercent'
        /// </summary>
        [Test]
        public void TwoHundredDayAverageChangePercentTest()
        {
            // TODO unit test for the property 'TwoHundredDayAverageChangePercent'
        }
        /// <summary>
        /// Test the property 'MarketCap'
        /// </summary>
        [Test]
        public void MarketCapTest()
        {
            // TODO unit test for the property 'MarketCap'
        }
        /// <summary>
        /// Test the property 'Ask'
        /// </summary>
        [Test]
        public void AskTest()
        {
            // TODO unit test for the property 'Ask'
        }
        /// <summary>
        /// Test the property 'BidSize'
        /// </summary>
        [Test]
        public void BidSizeTest()
        {
            // TODO unit test for the property 'BidSize'
        }
        /// <summary>
        /// Test the property 'AskSize'
        /// </summary>
        [Test]
        public void AskSizeTest()
        {
            // TODO unit test for the property 'AskSize'
        }
        /// <summary>
        /// Test the property 'MessageBoardId'
        /// </summary>
        [Test]
        public void MessageBoardIdTest()
        {
            // TODO unit test for the property 'MessageBoardId'
        }
        /// <summary>
        /// Test the property 'FullExchangeName'
        /// </summary>
        [Test]
        public void FullExchangeNameTest()
        {
            // TODO unit test for the property 'FullExchangeName'
        }
        /// <summary>
        /// Test the property 'LongName'
        /// </summary>
        [Test]
        public void LongNameTest()
        {
            // TODO unit test for the property 'LongName'
        }
        /// <summary>
        /// Test the property 'FinancialCurrency'
        /// </summary>
        [Test]
        public void FinancialCurrencyTest()
        {
            // TODO unit test for the property 'FinancialCurrency'
        }
        /// <summary>
        /// Test the property 'AverageDailyVolume3Month'
        /// </summary>
        [Test]
        public void AverageDailyVolume3MonthTest()
        {
            // TODO unit test for the property 'AverageDailyVolume3Month'
        }
        /// <summary>
        /// Test the property 'AverageDailyVolume10Day'
        /// </summary>
        [Test]
        public void AverageDailyVolume10DayTest()
        {
            // TODO unit test for the property 'AverageDailyVolume10Day'
        }
        /// <summary>
        /// Test the property 'FiftyTwoWeekLowChange'
        /// </summary>
        [Test]
        public void FiftyTwoWeekLowChangeTest()
        {
            // TODO unit test for the property 'FiftyTwoWeekLowChange'
        }
        /// <summary>
        /// Test the property 'FiftyTwoWeekLowChangePercent'
        /// </summary>
        [Test]
        public void FiftyTwoWeekLowChangePercentTest()
        {
            // TODO unit test for the property 'FiftyTwoWeekLowChangePercent'
        }
        /// <summary>
        /// Test the property 'FiftyTwoWeekRange'
        /// </summary>
        [Test]
        public void FiftyTwoWeekRangeTest()
        {
            // TODO unit test for the property 'FiftyTwoWeekRange'
        }
        /// <summary>
        /// Test the property 'FiftyTwoWeekHighChange'
        /// </summary>
        [Test]
        public void FiftyTwoWeekHighChangeTest()
        {
            // TODO unit test for the property 'FiftyTwoWeekHighChange'
        }
        /// <summary>
        /// Test the property 'FiftyTwoWeekHighChangePercent'
        /// </summary>
        [Test]
        public void FiftyTwoWeekHighChangePercentTest()
        {
            // TODO unit test for the property 'FiftyTwoWeekHighChangePercent'
        }
        /// <summary>
        /// Test the property 'FiftyTwoWeekLow'
        /// </summary>
        [Test]
        public void FiftyTwoWeekLowTest()
        {
            // TODO unit test for the property 'FiftyTwoWeekLow'
        }
        /// <summary>
        /// Test the property 'FiftyTwoWeekHigh'
        /// </summary>
        [Test]
        public void FiftyTwoWeekHighTest()
        {
            // TODO unit test for the property 'FiftyTwoWeekHigh'
        }
        /// <summary>
        /// Test the property 'TrailingPE'
        /// </summary>
        [Test]
        public void TrailingPETest()
        {
            // TODO unit test for the property 'TrailingPE'
        }
        /// <summary>
        /// Test the property 'Market'
        /// </summary>
        [Test]
        public void MarketTest()
        {
            // TODO unit test for the property 'Market'
        }
        /// <summary>
        /// Test the property 'ShortName'
        /// </summary>
        [Test]
        public void ShortNameTest()
        {
            // TODO unit test for the property 'ShortName'
        }
        /// <summary>
        /// Test the property 'ForwardPE'
        /// </summary>
        [Test]
        public void ForwardPETest()
        {
            // TODO unit test for the property 'ForwardPE'
        }
        /// <summary>
        /// Test the property 'PriceToBook'
        /// </summary>
        [Test]
        public void PriceToBookTest()
        {
            // TODO unit test for the property 'PriceToBook'
        }
        /// <summary>
        /// Test the property 'SourceInterval'
        /// </summary>
        [Test]
        public void SourceIntervalTest()
        {
            // TODO unit test for the property 'SourceInterval'
        }
        /// <summary>
        /// Test the property 'ExchangeTimezoneName'
        /// </summary>
        [Test]
        public void ExchangeTimezoneNameTest()
        {
            // TODO unit test for the property 'ExchangeTimezoneName'
        }
        /// <summary>
        /// Test the property 'ExchangeTimezoneShortName'
        /// </summary>
        [Test]
        public void ExchangeTimezoneShortNameTest()
        {
            // TODO unit test for the property 'ExchangeTimezoneShortName'
        }
        /// <summary>
        /// Test the property 'GmtOffSetMilliseconds'
        /// </summary>
        [Test]
        public void GmtOffSetMillisecondsTest()
        {
            // TODO unit test for the property 'GmtOffSetMilliseconds'
        }
        /// <summary>
        /// Test the property 'EsgPopulated'
        /// </summary>
        [Test]
        public void EsgPopulatedTest()
        {
            // TODO unit test for the property 'EsgPopulated'
        }
        /// <summary>
        /// Test the property 'Tradeable'
        /// </summary>
        [Test]
        public void TradeableTest()
        {
            // TODO unit test for the property 'Tradeable'
        }
        /// <summary>
        /// Test the property 'Triggerable'
        /// </summary>
        [Test]
        public void TriggerableTest()
        {
            // TODO unit test for the property 'Triggerable'
        }
        /// <summary>
        /// Test the property 'ExchangeDataDelayedBy'
        /// </summary>
        [Test]
        public void ExchangeDataDelayedByTest()
        {
            // TODO unit test for the property 'ExchangeDataDelayedBy'
        }
        /// <summary>
        /// Test the property 'Symbol'
        /// </summary>
        [Test]
        public void SymbolTest()
        {
            // TODO unit test for the property 'Symbol'
        }

    }

}
