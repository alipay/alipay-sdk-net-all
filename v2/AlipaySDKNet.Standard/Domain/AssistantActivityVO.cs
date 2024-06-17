using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssistantActivityVO Data Structure.
    /// </summary>
    [Serializable]
    public class AssistantActivityVO : AopObject
    {
        /// <summary>
        /// 活动跳转行动点
        /// </summary>
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 活动跳转地址
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 人群code，需要通过<a href="https://opendocs.alipay.com/open/09c10677_alipay.marketing.qipan.crowdoperation.create?pathHash=3d8bad63">棋盘人群创建接口</a>创建并获取返回crowd_code作为这个地方传的人群code参数
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 活动描述，可以不填
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片文件id，支持的图片 jpg、jpeg、png，宽高1:1，大小小于2M，请先通过图片上传接口上传图片<a href="https://opendocs.alipay.com/apis/036ros">https://opendocs.alipay.com/apis/036ros</a> 并获取到 file_id 作为这个入参的值
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 活动标题，展示在c端小助手内的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
