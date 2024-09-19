using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DonateBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DonateBillInfo : AopObject
    {
        /// <summary>
        /// 日期格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("donate_date")]
        public string DonateDate { get; set; }

        /// <summary>
        /// true 表示超过门槛，false表示没超过门槛
        /// </summary>
        [XmlElement("donate_doorsill")]
        public bool DonateDoorsill { get; set; }

        /// <summary>
        /// 用户捐赠支付宝公益项目的id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 用户捐赠支付宝公益项目的名称
        /// </summary>
        [XmlElement("project_title")]
        public string ProjectTitle { get; set; }
    }
}
