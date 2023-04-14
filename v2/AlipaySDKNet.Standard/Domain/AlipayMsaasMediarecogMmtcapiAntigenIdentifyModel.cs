using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcapiAntigenIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcapiAntigenIdentifyModel : AopObject
    {
        /// <summary>
        /// 算法业务标识id，调用对应算法前请联系接口负责人获取
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 入参图片信息
        /// </summary>
        [XmlArray("image_info_list")]
        [XmlArrayItem("image_infos")]
        public List<ImageInfos> ImageInfoList { get; set; }

        /// <summary>
        /// 蚂蚁统一开放ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 自定义参数，json格式
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
