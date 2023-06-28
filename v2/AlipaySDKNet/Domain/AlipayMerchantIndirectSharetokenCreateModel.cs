using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectSharetokenCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectSharetokenCreateModel : AopObject
    {
        /// <summary>
        /// 通过吱口令打开支付宝后的页面跳转链接，例如服务商支付页URL
        /// </summary>
        [XmlElement("biz_link")]
        public string BizLink { get; set; }

        /// <summary>
        /// 业务场景码定义，用以区分吱口令应用的业务场景。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 吱口令有效期，单位秒。例如:3600*24 (代表一天)
        /// </summary>
        [XmlElement("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 该参数为开放平台为服务商用户分配的用户唯一标识
        /// </summary>
        [XmlElement("out_open_id")]
        public string OutOpenId { get; set; }

        /// <summary>
        /// 订单需要支付的金额，单位为元(人民币)，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付宝间连商户SMID
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
