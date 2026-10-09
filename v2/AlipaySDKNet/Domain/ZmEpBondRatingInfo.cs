using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmEpBondRatingInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmEpBondRatingInfo : AopObject
    {
        /// <summary>
        /// 发行人名称
        /// </summary>
        [XmlElement("issuer_name")]
        public string IssuerName { get; set; }

        /// <summary>
        /// 评级
        /// </summary>
        [XmlElement("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// 变动方向
        /// </summary>
        [XmlElement("rating_change")]
        public string RatingChange { get; set; }

        /// <summary>
        /// 评级公司
        /// </summary>
        [XmlElement("rating_company")]
        public string RatingCompany { get; set; }

        /// <summary>
        /// 评级日期
        /// </summary>
        [XmlElement("rating_date")]
        public string RatingDate { get; set; }

        /// <summary>
        /// 评级对象
        /// </summary>
        [XmlElement("rating_object")]
        public string RatingObject { get; set; }

        /// <summary>
        /// 展望
        /// </summary>
        [XmlElement("rating_outlook")]
        public string RatingOutlook { get; set; }

        /// <summary>
        /// 评级方式
        /// </summary>
        [XmlElement("rating_type")]
        public string RatingType { get; set; }
    }
}
