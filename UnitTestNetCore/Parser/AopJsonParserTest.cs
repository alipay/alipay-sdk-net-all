using NUnit.Framework;
using System;
using Aop.Api.Request;
using Aop.Api.Parser;
using Aop.Api.Response;

namespace Test
{

    [TestFixture()]
    public class AopJsonParserTest
    {
        private AopJsonParser<AlipayTradeCreateResponse> JsonParser = new AopJsonParser<AlipayTradeCreateResponse>();

        [Test()]
        public void should_extract_correct_source_data_and_sign()
        {
            AlipayTradeCreateRequest request = new AlipayTradeCreateRequest();
            String responseBody = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\","
                    + "\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignItem signItem = JsonParser.GetSignItem(request, responseBody);

            Assert.AreEqual(signItem.SignSourceDate, "{\"code\":\"10000\",\"msg\":\"Success\",\"out_trade_no\":\"20150320010101001\","
                    + "\"trade_no\":\"2019062322001446881000041395\"}");
            Assert.AreEqual(signItem.Sign, "TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                            + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                            + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                            + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                            + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==");
        }

        [Test()]
        public void should_get_exception_when_has_duplication_response_node()
        {
            AlipayTradeCreateRequest request = new AlipayTradeCreateRequest();
            String responseBody = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\","
                    + "\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\"},"
                    + "\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\",\"out_trade_no\":\"forged\","
                    + "\"trade_no\":\"forged\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            try
            {
                JsonParser.GetSignItem(request, responseBody);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "检测到响应报文中有重复的alipay_trade_create_response，验签失败。");
            }
        }

        [Test()]
        public void should_not_get_exception_when_has_same_response_node_nested_in_inner_map()
        {
            AlipayTradeCreateRequest request = new AlipayTradeCreateRequest();
            String responseBody = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\","
                    + "\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\","
                    + "\"alipay_trade_create_response\":\"test\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignItem signItem = JsonParser.GetSignItem(request, responseBody);

            Assert.AreEqual(signItem.SignSourceDate, "{\"code\":\"10000\",\"msg\":\"Success\",\"out_trade_no\":\"20150320010101001\","
                    + "\"trade_no\":\"2019062322001446881000041395\",\"alipay_trade_create_response\":\"test\"}");
            Assert.AreEqual(signItem.Sign, "TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                            + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                            + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                            + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                            + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==");
        }

        [Test()]
        public void should_be_able_to_convert_json_to_response_object()
        {
            string body = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\",\"out_trade_no\":\"20150320010101001\","
        + "\"fund_bill_list\":[{\"amount\":\"123\"},{\"amount\":\"456\"}],\"voucher_detail_list\":[{\"id\":\"id123\","
        + "\"other_contribute_detail\":[{\"contribute_amount\":\"123\"}]}],\"test1\":{\"id\":\"id222\","
        + "\"other_contribute_detail\":[{\"contribute_amount\":\"222\"}]},\"test2\":123,\"test3\":5223434252345,\"test4\":1234567.89,"
        + "\"test5\":true,\"test6\":null,\"test_list1\":[123,123,123],\"test_list2\":[5223434252345,5223434252345,5223434252345],"
        + "\"test_list3\":[1234567.89,1234567.89,1234567.89],\"test_list4\":[true,false,true],\"test_list5\":[\"a\",null,\"c\"],},"
        + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5\"}";
            AopJsonParser<AlipayTradeQueryResponse> parser = new AopJsonParser<AlipayTradeQueryResponse>();
            AlipayTradeQueryResponse resposne = parser.Parse(body, "utf-8");
            Assert.AreEqual(resposne.Msg, "Success");
            Assert.AreEqual(resposne.OutTradeNo, "20150320010101001");
            Assert.AreEqual(resposne.OutTradeNo, "20150320010101001");
            Assert.AreEqual(resposne.FundBillList.Count, 2);
            Assert.AreEqual(resposne.FundBillList[0].Amount, "123");
            Assert.AreEqual(resposne.VoucherDetailList[0].OtherContributeDetail[0].ContributeAmount, "123");

            Assert.AreEqual(resposne.Test1.Id, "id222");
            Assert.AreEqual(resposne.Test1.OtherContributeDetail[0].ContributeAmount, "222");

            Assert.AreEqual(resposne.Test2, 123);
            Assert.AreEqual(resposne.Test3, 5223434252345);
            Assert.AreEqual(resposne.Test4, 1234567.89);
            Assert.AreEqual(resposne.Test5, true);
            Assert.AreEqual(resposne.Test6, null);

            Assert.AreEqual(resposne.TestList1[2], 123);
            Assert.AreEqual(resposne.TestList2[2], 5223434252345);
            Assert.AreEqual(resposne.TestList3[2], 1234567.89);
            Assert.AreEqual(resposne.TestList4[2], true);
            Assert.AreEqual(resposne.TestList5[1], null);
            Assert.AreEqual(resposne.TestList5[2], "c");
        }
    }
}
