using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainSignIndexCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainSignIndexCreateModel : AopObject
    {
        /// <summary>
        /// 应用名，必填， 如cif
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 签约业务主体，必填， 如Z50
        /// </summary>
        [XmlElement("biz_corp")]
        public string BizCorp { get; set; }

        /// <summary>
        /// 签约业务来源，必填，如花呗协议签约数据落在CIF，填CIF
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 签约业务场景, 必填, 如花呗业务的话，填产品码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 签约索引业务唯一键，必填，如协议ID号
        /// </summary>
        [XmlElement("biz_unique_key")]
        public string BizUniqueKey { get; set; }

        /// <summary>
        /// 0xxxca
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 签约主体ID， 必填， 请填签约用户的userId
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 签约主体ID类型， 必填， 用户填USER， 客户填CUSTOMER
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 版本号，必填， 如时间戳或者数据库业务表的版本号;应该是version,由于平台限制，使用这个
        /// </summary>
        [XmlElement("sign_version")]
        public long SignVersion { get; set; }

        /// <summary>
        /// 签约租户，必填， 主站请填 MAIN_SITE
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 签约有效结束时间，必填
        /// </summary>
        [XmlElement("valid_end_date")]
        public string ValidEndDate { get; set; }

        /// <summary>
        /// 签约有效开始时间，必填
        /// </summary>
        [XmlElement("valid_start_date")]
        public string ValidStartDate { get; set; }
    }
}
