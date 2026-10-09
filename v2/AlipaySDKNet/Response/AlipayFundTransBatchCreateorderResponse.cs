using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransBatchCreateorderResponse.
    /// </summary>
    public class AlipayFundTransBatchCreateorderResponse : AopResponse
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展信息；创建付款单时传入的相关数据
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        [XmlElement("transfer_no")]
        public string TransferNo { get; set; }
    }
}
