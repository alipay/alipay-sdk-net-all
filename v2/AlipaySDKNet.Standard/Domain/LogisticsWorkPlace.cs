using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsWorkPlace Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsWorkPlace : AopObject
    {
        /// <summary>
        /// 描述铺设位置。对于铺设位置的进一步描述，方便进行作业区分。例如：主柜、副柜、驿站内1号柜。
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 铺设完成后，用户碰一下该线圈，实际需要跳转的地址
        /// </summary>
        [XmlElement("mini_app_redirect_url")]
        public string MiniAppRedirectUrl { get; set; }

        /// <summary>
        /// 铺设位置地址。如果该值为空，铺设位置会取值铺设点位的位置信息
        /// </summary>
        [XmlElement("work_place_address")]
        public BusinessAddress WorkPlaceAddress { get; set; }

        /// <summary>
        /// 表示线圈铺设实际铺设位置。例如：一个柜组下有3个柜子需要铺设线圈，柜组为铺设点位，待铺设的柜子为实际铺设位置。
        /// </summary>
        [XmlElement("work_place_id")]
        public string WorkPlaceId { get; set; }

        /// <summary>
        /// 表示线圈铺设实际铺设位置。例如：一个柜组下有3个柜子需要铺设线圈，柜组为铺设点位，待铺设的柜子为实际铺设位置。
        /// </summary>
        [XmlElement("work_place_name")]
        public string WorkPlaceName { get; set; }
    }
}
