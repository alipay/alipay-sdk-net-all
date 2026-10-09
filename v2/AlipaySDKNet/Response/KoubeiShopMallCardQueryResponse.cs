using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiShopMallCardQueryResponse.
    /// </summary>
    public class KoubeiShopMallCardQueryResponse : AopResponse
    {
        /// <summary>
        /// 商圈发行的会员卡信息
        /// </summary>
        [XmlArray("cards")]
        [XmlArrayItem("mall_card_bo")]
        public List<MallCardBo> Cards { get; set; }

        /// <summary>
        /// 是否开通会员系统功能
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 商圈会员开卡链接
        /// </summary>
        [XmlElement("open_card_url")]
        public string OpenCardUrl { get; set; }
    }
}
