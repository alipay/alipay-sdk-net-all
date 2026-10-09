using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureFileApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacefeatureFileApplyModel : AopObject
    {
        /// <summary>
        /// SCHOOL_PAYMENT
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 需要请求的特征版本
        /// </summary>
        [XmlElement("feature_version")]
        public string FeatureVersion { get; set; }

        /// <summary>
        /// 需要请求的文件日期
        /// </summary>
        [XmlElement("file_date")]
        public string FileDate { get; set; }

        /// <summary>
        /// 需要请求的文件类型,ALL:全量,INCREASE:增量,REALTIME:实时
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 国家统一分配的学校社会信用代码(institution_id)
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 必须是由支付宝业务方分配的英文简称(例如:yikeshi),不能是中文
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }
    }
}
