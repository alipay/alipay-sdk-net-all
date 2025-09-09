using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderSmidCoilpaydescriptionQueryResponse.
    /// </summary>
    public class AlipayOfflineProviderSmidCoilpaydescriptionQueryResponse : AopResponse
    {
        /// <summary>
        /// 商家间连小蓝环交易情况的概括性描述，用于作业人员判断当前作业商户是否已经产生小蓝环交易。
        /// </summary>
        [XmlElement("merchant_coil_pay_description")]
        public string MerchantCoilPayDescription { get; set; }

        /// <summary>
        /// 支付宝间连商户smid，值同接口传入的sub_merchant_id
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
