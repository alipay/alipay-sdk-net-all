using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCardGenerateQueryResponse.
    /// </summary>
    public class AlipayFundCardGenerateQueryResponse : AopResponse
    {
        /// <summary>
        /// 接收制卡请求落地之后的返回的支付宝制卡单号
        /// </summary>
        [XmlElement("fund_card_generate_no")]
        public string FundCardGenerateNo { get; set; }

        /// <summary>
        /// 卡生成的时间
        /// </summary>
        [XmlElement("generate_finish_time")]
        public string GenerateFinishTime { get; set; }

        /// <summary>
        /// 确认交付的时间
        /// </summary>
        [XmlElement("proces_finish_time")]
        public string ProcesFinishTime { get; set; }

        /// <summary>
        /// INIT-初始化 ACCEPTED - 已受理 PROCESSING - 处理中 WAIT_RETRY - 待重试 GENERATED - 制作完成 FINISHED - 已交付 CLOSE - 已取消
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
