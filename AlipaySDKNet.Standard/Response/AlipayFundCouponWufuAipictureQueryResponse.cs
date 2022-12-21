using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundCouponWufuAipictureQueryResponse.
    /// </summary>
    public class AlipayFundCouponWufuAipictureQueryResponse : AopResponse
    {
        /// <summary>
        /// AI年画图片列表
        /// </summary>
        [XmlArray("ai_picture_list")]
        [XmlArrayItem("ai_picture_v_o")]
        public List<AiPictureVO> AiPictureList { get; set; }
    }
}
