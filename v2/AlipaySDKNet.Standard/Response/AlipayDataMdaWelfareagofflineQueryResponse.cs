using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaWelfareagofflineQueryResponse.
    /// </summary>
    public class AlipayDataMdaWelfareagofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 火苗捐赠总数
        /// </summary>
        [XmlElement("donate_flame_cnt")]
        public long DonateFlameCnt { get; set; }

        /// <summary>
        /// 捐赠小学
        /// </summary>
        [XmlElement("donate_school")]
        public long DonateSchool { get; set; }

        /// <summary>
        /// 火苗总数
        /// </summary>
        [XmlElement("flame_cnt")]
        public long FlameCnt { get; set; }

        /// <summary>
        /// 完成火苗捐赠人数
        /// </summary>
        [XmlElement("total_donate_user")]
        public long TotalDonateUser { get; set; }

        /// <summary>
        /// 获取火苗人数
        /// </summary>
        [XmlElement("total_obtain_user")]
        public long TotalObtainUser { get; set; }
    }
}
