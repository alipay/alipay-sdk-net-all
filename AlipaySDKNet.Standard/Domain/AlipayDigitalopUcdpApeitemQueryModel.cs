using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalopUcdpApeitemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalopUcdpApeitemQueryModel : AopObject
    {
        /// <summary>
        /// 推荐上下文
        /// </summary>
        [XmlElement("context")]
        public ApeRecContext Context { get; set; }

        /// <summary>
        /// 已经曝光的item列表，用于曝光去重，多个itemid用,分割，这部分item不会出现在推荐结果中。
        /// </summary>
        [XmlArray("exposed_item_list")]
        [XmlArrayItem("string")]
        public List<string> ExposedItemList { get; set; }

        /// <summary>
        /// 待推荐候选集itemId列表，用于调用方指定推荐item的范围，推荐接口将对传入的item进行打分，可为空。
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 加密userID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 当前页码，第一页是1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的大小，取值范围是1~500。分页参数为空时默认返回最多500个item。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家在蚂蚁推荐引擎创建的项目id，调用前需要找蚂蚁技术获取。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 可以关联到用户的标识信息，用于关联用户的特征。例如手机号、设备号、邮箱等。格式为：“类型#sha256(值）”，类型枚举有：PHONE（手机号）、DEVICE（设备号）、EMAIL（邮箱）等，具体的值是用sha256进行哈希之后的hex表示，多个标识信息用,分割。
        /// </summary>
        [XmlElement("relevant_id")]
        public string RelevantId { get; set; }

        /// <summary>
        /// 标识一次用户会话的id，用于稳定分页。如果翻页过程中，item_total_count为0，说明分页数据失效，请重新请求第一页以刷新数据。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户唯一标识id，可以是支付宝userid、商家自定义的userid等
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户id的类型，可选值：ALIPAY（支付宝userid）、CUSTOM（商家自定义的userid）
        /// </summary>
        [XmlElement("user_id_type")]
        public string UserIdType { get; set; }
    }
}
