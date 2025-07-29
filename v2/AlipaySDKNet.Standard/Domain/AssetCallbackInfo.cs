using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetCallbackInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetCallbackInfo : AopObject
    {
        /// <summary>
        /// 是哪一个交互动作之后的回调
        /// </summary>
        [XmlElement("biz_action")]
        public string BizAction { get; set; }

        /// <summary>
        /// 回调操作的唯一键
        /// </summary>
        [XmlElement("biz_key_value")]
        public string BizKeyValue { get; set; }

        /// <summary>
        /// 用来确认回调信息的准确性，判断是否需要重试
        /// </summary>
        [XmlArray("callback_infos")]
        [XmlArrayItem("asset_sub_feedback_info")]
        public List<AssetSubFeedbackInfo> CallbackInfos { get; set; }

        /// <summary>
        /// 无此分配指令
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 物料版本反馈信息
        /// </summary>
        [XmlElement("feedback_info")]
        public AssetItemVersionFeedBackInfo FeedbackInfo { get; set; }

        /// <summary>
        /// 是否处理成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
