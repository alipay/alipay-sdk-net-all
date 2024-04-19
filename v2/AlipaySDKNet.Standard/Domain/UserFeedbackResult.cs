using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserFeedbackResult Data Structure.
    /// </summary>
    [Serializable]
    public class UserFeedbackResult : AopObject
    {
        /// <summary>
        /// 与appid对应
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 重要级别,目前支持PO/P1/E0/C0/C1
        /// </summary>
        [XmlElement("biz_level_update")]
        public string BizLevelUpdate { get; set; }

        /// <summary>
        /// 客户端反馈
        /// </summary>
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 用户反馈所在地
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 当前反馈支付宝端版本
        /// </summary>
        [XmlElement("clientproduct_version")]
        public string ClientproductVersion { get; set; }

        /// <summary>
        /// 反馈意图
        /// </summary>
        [XmlElement("cls_intention")]
        public string ClsIntention { get; set; }

        /// <summary>
        /// 用户反馈的内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 用户反馈提交时间
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 用户反馈设备型号
        /// </summary>
        [XmlElement("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// anteye平台打标舆情话题
        /// </summary>
        [XmlElement("dm_subject")]
        public string DmSubject { get; set; }

        /// <summary>
        /// 用户反馈情感正负面
        /// </summary>
        [XmlElement("emotion")]
        public string Emotion { get; set; }

        /// <summary>
        /// 舆情处理的状态
        /// </summary>
        [XmlElement("handle_status")]
        public string HandleStatus { get; set; }

        /// <summary>
        /// 当前舆情的处理时间
        /// </summary>
        [XmlElement("handle_time")]
        public string HandleTime { get; set; }

        /// <summary>
        /// anteye系统唯一id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("last_deal_emp_id")]
        public string LastDealEmpId { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("new_category")]
        public string NewCategory { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [XmlElement("new_category_name")]
        public string NewCategoryName { get; set; }

        /// <summary>
        /// 用户的uid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 手机系统
        /// </summary>
        [XmlElement("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// 手机系统版本
        /// </summary>
        [XmlElement("os_version")]
        public string OsVersion { get; set; }

        /// <summary>
        /// 图片的地址
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 反馈来源平台： 安卓系为1  苹果系为2  其他为3
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// replays日志平台id
        /// </summary>
        [XmlElement("replays_id")]
        public string ReplaysId { get; set; }

        /// <summary>
        /// 舆情连接（anteye）
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 用户的uid
        /// </summary>
        [XmlElement("userid")]
        public string Userid { get; set; }
    }
}
