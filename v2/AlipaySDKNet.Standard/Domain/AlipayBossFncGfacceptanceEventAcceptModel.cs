using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfacceptanceEventAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfacceptanceEventAcceptModel : AopObject
    {
        /// <summary>
        /// 受理幂等字段，唯一标识一笔报帐单据。当收到两笔相同的acceptUniqueNo时，第二笔会被当作是重复报送不作处理。因此对于同一笔交易在不同阶段（比如订单创建、确认收货、退款等）触发的不同财务事件，也应该采用不同的acceptUniqueNo
        /// </summary>
        [XmlElement("accept_uniq_no")]
        public string AcceptUniqNo { get; set; }

        /// <summary>
        /// 签约合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 业务事件码，长度必须小于等于8
        /// </summary>
        [XmlElement("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("biz_pd_code")]
        public string BizPdCode { get; set; }

        /// <summary>
        /// 端事件码（8位数字）
        /// </summary>
        [XmlElement("cnl_ev_code")]
        public string CnlEvCode { get; set; }

        /// <summary>
        /// 端产品码，长度必须小于等于64
        /// </summary>
        [XmlElement("cnl_pd_code")]
        public string CnlPdCode { get; set; }

        /// <summary>
        /// 业财事件受理模型，事件处理码，事件处理参数，事件触发条件，事件触发时间等主要内容定义在这里。
        /// </summary>
        [XmlElement("event_acceptance")]
        public GFAOpenAPIEventAcceptance EventAcceptance { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务流水号（受理幂等字段之一），长度必须小于等于128
        /// </summary>
        [XmlElement("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 16位。支付宝UID或者2088000000000XX0，倒数2、3位数字用来决策LDC ZoneUid和分库位
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务唯一标识（受理幂等字段之一），长度必须小于等于12
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 外部业务子单据号（受理幂等字段之一），长度必须小于等于128
        /// </summary>
        [XmlElement("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
