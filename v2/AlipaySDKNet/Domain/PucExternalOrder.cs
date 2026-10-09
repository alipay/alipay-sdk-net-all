using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PucExternalOrder Data Structure.
    /// </summary>
    [Serializable]
    public class PucExternalOrder : AopObject
    {
        /// <summary>
        /// 公共事业单位收费账号对应的地址或者收费商户自行定义的地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 金额字符串, 以元为单位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易对应的账期, 支持YYYYMM月账期模式和YYYYMMDD的日账期模式
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 缴费收费账号, 由收费单位定义
        /// </summary>
        [XmlElement("billkey")]
        public string Billkey { get; set; }

        /// <summary>
        /// 缴费业务类型, 默认JF
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务附加参数, 传入jsonstr
        /// </summary>
        [XmlElement("business_param")]
        public string BusinessParam { get; set; }

        /// <summary>
        /// 缴费收费单位短名, 由缴费系统生成唯一标识
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 用于查缴关联的串号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 特殊场景外部输入的结算SMID
        /// </summary>
        [XmlElement("extra_settle_entity_id")]
        public string ExtraSettleEntityId { get; set; }

        /// <summary>
        /// 公共事业单位对应的实名认证户名或者收费商家自行分配的中文名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户侧订单的唯一标识, 商户侧保持唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 生活缴费收单场景不支持自定义分账, 如需自定义分账,场景申请联系支付宝生活缴费团队
        /// </summary>
        [XmlArray("royalty_parameters")]
        [XmlArrayItem("puc_royalty_detail_info")]
        public List<PucRoyaltyDetailInfo> RoyaltyParameters { get; set; }

        /// <summary>
        /// 缴费子业务类型, 关联费种
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 传入服务商ID用于返佣
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
