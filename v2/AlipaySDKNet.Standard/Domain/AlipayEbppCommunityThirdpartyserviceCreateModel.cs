using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityThirdpartyserviceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityThirdpartyserviceCreateModel : AopObject
    {
        /// <summary>
        /// 服务验收视频链接
        /// </summary>
        [XmlElement("check_video_url")]
        public string CheckVideoUrl { get; set; }

        /// <summary>
        /// 支付宝小区编码，由支付宝分配，可在创建小区接口的返回中获取
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 外部小区id
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }

        /// <summary>
        /// 服务编码，由支付宝分配
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务的访问地址，必须是alipays开头，最长1024字符，必填
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
