using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeScenepaySharecodetestCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeScenepaySharecodetestCreateModel : AopObject
    {
        /// <summary>
        /// 通过吱口令打开支付宝后的页面跳转链接，例如服务商支付页URL
        /// </summary>
        [XmlElement("biz_link")]
        public string BizLink { get; set; }

        /// <summary>
        /// 业务场景码，用于识别吱口令场景，区分回流弹窗样式，请与对接同学确认应用场景后获取
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务跟踪参数，用于串联用户业务行为的关系
        /// </summary>
        [XmlElement("biz_tracker")]
        public string BizTracker { get; set; }

        /// <summary>
        /// 渠道信息摘要标识，在APP内吱口令跳转时用到，用来标识吱口令关联的服务信息，比如红包、花呗工具。有两种方式获得：1.在于支付宝进行业务合作时，由平台侧分配；2.在咨询前置服务时由接口返回
        /// </summary>
        [XmlElement("channel_info")]
        public string ChannelInfo { get; set; }

        /// <summary>
        /// 吱口令有效期，单位秒。例如:300 (代表5分钟)
        /// </summary>
        [XmlElement("expire_time")]
        public long ExpireTime { get; set; }

        /// <summary>
        /// 商户的名称，用于在回流弹窗页显示
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 外部业务号，需要保障幂等性
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
