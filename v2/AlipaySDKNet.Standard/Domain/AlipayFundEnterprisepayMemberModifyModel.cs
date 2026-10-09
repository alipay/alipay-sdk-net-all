using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundEnterprisepayMemberModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundEnterprisepayMemberModifyModel : AopObject
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
        /// 员工当前关联的群组ID，支持多个
        /// </summary>
        [XmlArray("group_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupIdList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 更新操作类型：多个时逗号分隔 GROUP-群组信息 FUND-出资信息 字段不传时，默认全量更新
        /// </summary>
        [XmlArray("operation_type_list")]
        [XmlArrayItem("string")]
        public List<string> OperationTypeList { get; set; }

        /// <summary>
        /// 产品码，默认值 ENTERPRISE_PAY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
