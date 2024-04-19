using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudDetailQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCloudDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户金融云展示的小程序信息列表
        /// </summary>
        [XmlArray("miniapp_cloud_detail_info_list")]
        [XmlArrayItem("miniapp_cloud_detail_info")]
        public List<MiniappCloudDetailInfo> MiniappCloudDetailInfoList { get; set; }

        /// <summary>
        /// partner_id，如果只传入了APPID，返回该appid的pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }
    }
}
