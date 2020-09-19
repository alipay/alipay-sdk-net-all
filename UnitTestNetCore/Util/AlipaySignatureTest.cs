using System;
using NUnit.Framework;
using Aop.Api.Util;
using System.Collections.Generic;
using Aop.Api;

namespace Test
{
    [TestFixture()]
    public class AlipaySignatureTest
    {
        [Test()]
        public void should_return_correct_cert_sn()
        {
            string sn = AlipaySignature.GetCertSN(TestAccount.ProdCert.CertParams.AppCertPath);
            Assert.AreEqual(sn, "f8e04719723c16b0ff796dcd0d8d7641");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_is_normal_json()
        {
            string response = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\","
                    + "\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"code\":\"10000\",\"msg\":\"Success\","
                    + "\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\"}");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_has_nested_object()
        {
            string response = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\",\"nested\":{\"a\":1,\"b\":\"2\"},"
                    + "\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"code\":\"10000\",\"msg\":\"Success\",\"nested\":{\"a\":1,\"b\":\"2\"},"
                    + "\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\"}");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_has_nested_array()
        {
            String response = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\",\"nested\":{\"a\":1,\"b\":\"2\","
                    + "\"array\":[\"1\",\"2\",\"3\"]},\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"code\":\"10000\",\"msg\":\"Success\",\"nested\":{\"a\":1,\"b\":\"2\","
                    + "\"array\":[\"1\",\"2\",\"3\"]},\"out_trade_no\":\"20150320010101001\",\"trade_no\":\"2019062322001446881000041395\"}");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_has_paired_braces_in_json_value()
        {
            string response = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\",\"nested\":{\"a\":1,\"b\":\"2\","
                    + "\"array\":[\"1\",\"2\",\"3\"]},\"out_trade_no\":\"201{5}0320010101001{}\","
                    + "\"trade_no\":\"2019062322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"code\":\"10000\",\"msg\":\"Success\",\"nested\":{\"a\":1,\"b\":\"2\","
                    + "\"array\":[\"1\",\"2\",\"3\"]},\"out_trade_no\":\"201{5}0320010101001{}\","
                    + "\"trade_no\":\"2019062322001446881000041395\"}");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_has_paired_braces_in_json_key()
        {
            string response = "{\"alipay_trade_create_response\":{\"code\":\"10000\",\"msg\":\"Success\",\"nested\":{\"a\":1,\"b\":\"2\","
                    + "\"array\":[\"1\",\"2\",\"3\"]},\"out_{trade}_{no}\":\"201{5}0320010101001{}\","
                    + "\"trade_no\":\"2019062322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"code\":\"10000\",\"msg\":\"Success\",\"nested\":{\"a\":1,\"b\":\"2\","
                    + "\"array\":[\"1\",\"2\",\"3\"]},\"out_{trade}_{no}\":\"201{5}0320010101001{}\","
                    + "\"trade_no\":\"2019062322001446881000041395\"}");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_has_not_paired_brace_in_json_value()
        {
            string response = "{\"alipay_trade_create_response\":{\"code\":\"100}00\",\"msg\":\"Suc}cess\",\"nested\":{\"a\":1,\"b\":\"2\","
                    + "\"array\":[\"{1\",\"2\",\"3\"]},\"out_{trade}_{no}\":\"201{5}0320010101001{}\","
                    + "\"trade_no\":\"2019062{322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"code\":\"100}00\",\"msg\":\"Suc}cess\",\"nested\":{\"a\":1,\"b\":\"2\","
                    + "\"array\":[\"{1\",\"2\",\"3\"]},\"out_{trade}_{no}\":\"201{5}0320010101001{}\","
                    + "\"trade_no\":\"2019062{322001446881000041395\"}");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_has_not_paired_brace_in_json_key()
        {
            string response = "{\"alipay_trade_create_response\":{\"co{de\":\"100}00\",\"ms}g\":\"Suc}cess\",\"ne{sted\":{\"a\":1,"
                    + "\"b\":\"2\",\"array\":[\"{1\",\"2\",\"3\"]},\"{out_{trade}_{no}\":\"201{5}0320010101001{}\","
                    + "\"trade_no}\":\"2019062{322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"co{de\":\"100}00\",\"ms}g\":\"Suc}cess\",\"ne{sted\":{\"a\":1,"
                    + "\"b\":\"2\",\"array\":[\"{1\",\"2\",\"3\"]},\"{out_{trade}_{no}\":\"201{5}0320010101001{}\","
                    + "\"trade_no}\":\"2019062{322001446881000041395\"}");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_has_not_paired_brace_and_quotation_in_json_value()
        {
            string response = "{\"alipay_trade_create_response\":{\"co{de\":\"100}00\",\"ms}g\":\"Suc\\\"}cess\",\"ne{sted\":{\"a\":1,"
                    + "\"b\":\"2\",\"array\":[\"\\\"{1\",\"2\",\"3\"]},\"{out_{trade}_{no}\":\"201{5\\\"}0320010101001{}\","
                    + "\"trade_no}\":\"20\\\"19062{322001446881000041395\"},"
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"co{de\":\"100}00\",\"ms}g\":\"Suc\\\"}cess\",\"ne{sted\":{\"a\":1,"
                    + "\"b\":\"2\",\"array\":[\"\\\"{1\",\"2\",\"3\"]},\"{out_{trade}_{no}\":\"201{5\\\"}0320010101001{}\","
                    + "\"trade_no}\":\"20\\\"19062{322001446881000041395\"}");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_has_even_consecutive_escape_count_before_quotation_in_json_key_and_value()
        {
            string response = "{\"alipay_trade_create_response\":{\"code\":\"10000\\\\\",         \"msg\": \"Success\",         "
                    + "\"\\\\out_trade_no\\\\\": \"\\\\\\\\20150320010101001\\\\\\\\\",         \"trade_no\": "
                    + "\"2019062322001446881000041395\"     },     \"sign\": "
                    + "\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\" }";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "{\"code\":\"10000\\\\\",         \"msg\": \"Success\",         \"\\\\out_trade_no\\\\\": "
                            + "\"\\\\\\\\20150320010101001\\\\\\\\\",         \"trade_no\": \"2019062322001446881000041395\"     }");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_encrypted()
        {
            string response = "{\"alipay_trade_create_response"
                    + "\":\"eyJjb2RlIjoiMTAwMDAiLCJtc2ciOiJTdWNjZXNzIiwib3V0X3RyYWRlX25vIjoiMjAxNTAzMjAwMTAxMDEwMDEiLCJ0"
                    + "cmFkZV9ubyI6IjIwMTkwNjIzMjIwMDE0NDY4ODEwMDAwNDEzOTUifQ==\","
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "\"eyJjb2RlIjoiMTAwMDAiLCJtc2ciOiJTdWNjZXNzIiwib3V0X3RyYWRlX25vIjoiMjAxNTAzMjAwMTAxMD"
                    + "EwMDEiLCJ0cmFkZV9ubyI6IjIwMTkwNjIzMjIwMDE0NDY4ODEwMDAwNDEzOTUifQ==\"");
        }

        [Test()]
        public void should_extract_correct_sign_content_when_response_encrypted_and_with_blank_space()
        {
            string response = "{\"alipay_trade_create_response"
                    + "\"      :      \"eyJjb2RlIjoiMTAwMDAiLCJtc2ciOiJTdWNjZXNzIiwib3V0X3RyYWRlX25vIjoiMjAxNTAzMjAwMTAxMDEwMDEiLCJ0"
                    + "cmFkZV9ubyI6IjIwMTkwNjIzMjIwMDE0NDY4ODEwMDAwNDEzOTUifQ==\","
                    + "\"sign\":\"TS355N0QjK1r9GyD4YOsG5esszSUhESgwu1q5"
                    + "+e1sWwqtPYe30CQ3v0QTEDdxYN9vm2No8V1KzuTSadrA4SZSkEkRchrcdVHCU8rCXOHWzS5wof8jg5S75y481kj3HqlpTaz"
                    + "/EhvAXK8iC8Xz9CgPmvfLmAUNkxy0q05yV2wZAGNX0WElUOx1Lcd2FqeuRFMvBOq5TQ+SVqunfUMLic8rYsW"
                    + "+smDHzIgjRcde8pHOZBMvmqDDzmyBLEgSbBswgHifQPDrhnGPlpk2U/nb8Sx7G8mWHEibtb8ClENcxtJEwcI0NN+erWO4Le"
                    + "+jFVUOU0BqC4dxGBNX9AHCTZMEhfcZQ==\"}";

            SignSourceData signSourceData = AlipaySignature.ExtractSignContent(response, 32);

            Assert.AreEqual(signSourceData.SourceData, "\"eyJjb2RlIjoiMTAwMDAiLCJtc2ciOiJTdWNjZXNzIiwib3V0X3RyYWRlX25vIjoiMjAxNTAzMjAwMTAxMD"
                    + "EwMDEiLCJ0cmFkZV9ubyI6IjIwMTkwNjIzMjIwMDE0NDY4ODEwMDAwNDEzOTUifQ==\"");
        }

        [Test()]
        public void should_pass_check_v1_when_sign_is_self_generated()
        {
            //gien
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "测试Key1", "测试Value1" },
                { "测试Key2", "测试Value2" }
            };
            parameters.Add("sign", AlipaySignature.Sign(parameters, TestAccount.Mock.AppPrivateKey, "UTF-8", "RSA2", false));
            parameters.Add("sign_type", "RSA2");

            //when
            bool result = AlipaySignature.VerifyV1(parameters, TestAccount.Mock.AppPublicKey, "UTF-8", "RSA2", false);

            //then
            Assert.AreEqual(result, true);
        }

        [Test()]
        public void should_pass_rsa_check_v2_when_sign_is_self_generated()
        {
            //gien
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "测试Key1", "测试Value1" },
                { "测试Key2", "测试Value2" },
                { "sign_type", "RSA2" }
            };
            parameters.Add("sign", AlipaySignature.Sign(parameters, TestAccount.Mock.AppPrivateKey, "UTF-8", "RSA2", false));


            //when
            bool result = AlipaySignature.VerifyV2(parameters, TestAccount.Mock.AppPublicKey, "UTF-8", "RSA2", false);

            //then
            Assert.AreEqual(result, true);
        }

        [Test()]
        public void should_pass_rsa_cert_check_v1_when_sign_is_self_generated()
        {
            //gien
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "测试Key1", "测试Value1" },
                { "测试Key2", "测试Value2" }
            };
            parameters.Add("sign", AlipaySignature.Sign(parameters, TestAccount.ProdCert.AppPrivateKey, "UTF-8", "RSA2", false));
            parameters.Add("sign_type", "RSA2");

            //when
            bool result = AlipaySignature.CertVerifyV1(parameters, TestAccount.ProdCert.CertParams.AppCertPath, "UTF-8", "RSA2");

            //then
            Assert.AreEqual(result, true);
        }

        [Test()]
        public void should_pass_rsa_cert_check_v2_when_sign_is_self_generated()
        {
            //gien
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "测试Key1", "测试Value1" },
                { "测试Key2", "测试Value2" },
                { "sign_type", "RSA2" }
            };
            parameters.Add("sign", AlipaySignature.Sign(parameters, TestAccount.ProdCert.AppPrivateKey, "UTF-8", "RSA2", false));

            //when
            bool result = AlipaySignature.CertVerifyV2(parameters, TestAccount.ProdCert.CertParams.AppCertPath, "UTF-8", "RSA2");

            //then
            Assert.AreEqual(result, true);
        }

        [Test()]
        public void should_pass_rsa_cert_check_v1_when_sign_is_self_generated_and_load_key_from_file()
        {
            //gien
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "测试Key1", "测试Value1" },
                { "测试Key2", "测试Value2" }
            };
            parameters.Add("sign", AlipaySignature.Sign(parameters, TestAccount.Mock.AppPrivateKeyFile, "UTF-8", "RSA2", true));
            parameters.Add("sign_type", "RSA2");

            //when
            bool result = AlipaySignature.VerifyV1(parameters, TestAccount.Mock.AppPublicKeyFile, "UTF-8", "RSA2", true);

            //then
            Assert.AreEqual(result, true);
        }

        [Test]
        public void should_get_xml_contains_essential_nodes_after_encrypt_and_sign()
        {
            string result = AlipaySignature.EncryptAndSign("test", TestAccount.Sandbox.AlipayPublicKey,
                TestAccount.Sandbox.AppPrivateKey, "UTF-8", true, true, "RSA2", false);

            Assert.AreEqual(result.Contains("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"), true);
            Assert.AreEqual(result.Contains("<alipay>"), true);
            Assert.AreEqual(result.Contains("<response>"), true);
            Assert.AreEqual(result.Contains("<encryption_type>RSA2</encryption_type>"), true);
            Assert.AreEqual(result.Contains("<sign>"), true);
        }

        [Test]
        public void should_get_exception_when_sign_not_match()
        {
            Dictionary<String, String> paramters = new Dictionary<string, string>
            {
                { "biz_content", "test" },
                { "charset", "UTF-8" },
                { "sign", "DFM24dXl9tfymSvZvmwcjutWWDoCwF2b/6CqUY2ZdShmnucUGxKqpmDF0m4lu5cm2AKx2KxvrfyOHrpZUBhX9i3YKqj0CV1jDjWBdcFI2gGnNQeShdqGGDhuHgtVeQE8cH/Q7LWSfrJ3EZqKyvCXsAX2GQ7SuhTPbIrq8mlflcIQHIUxUfoucc2F/vBdumwYQ3bT+2P4+7z89AFrPIDQ5A4dh1l3dkHbMTaJrFAz5bSvo5gqNyVV/TLts28HeHvAAYDfGP4eWm5knnh/3AulLdOkj0+m8L/YUR9tUMvNMSB6IJFF7keKq4s6qovfXPJYGZUNfuWKp9EJwDALGD53zg=="}
            };

            AopException ex = Assert.Throws<AopException>(() => AlipaySignature.CheckSignAndDecrypt(
                paramters, TestAccount.Sandbox.AlipayPublicKey, TestAccount.Sandbox.AppPrivateKey, true, true, "RSA", false));
            Assert.AreEqual(ex.Message.Contains("rsaCheck failure"), true);
        }
    }
}
