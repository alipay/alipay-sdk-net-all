using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeVisaReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeVisaReportQueryModel : AopObject
    {
        /// <summary>
        /// 接口是否要返回报告文件
        /// </summary>
        [XmlElement("include_file")]
        public bool IncludeFile { get; set; }

        /// <summary>
        /// 申请场景，报告申请国家
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
