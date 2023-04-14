using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundEnterprisepayGroupModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundEnterprisepayGroupModifyModel : AopObject
    {
        /// <summary>
        /// 企业签约账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 平台和企业的三方授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 出资信息
        /// </summary>
        [XmlElement("fund_ext_info")]
        public FundExtInfo FundExtInfo { get; set; }

        /// <summary>
        /// 群组名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 更新操作类型：多个时逗号分隔 NAME-群组名称 FUND-出资信息 字段不传时，默认全量更新
        /// </summary>
        [XmlArray("operation_type_list")]
        [XmlArrayItem("string")]
        public List<string> OperationTypeList { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码，默认值 ENTERPRISE_PAY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
