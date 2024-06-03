using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupmsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupmsgSendModel : AopObject
    {
        /// <summary>
        /// 是否需要@所有人，不传默认false(不需要@所有人)
        /// </summary>
        [XmlElement("at_all")]
        public bool AtAll { get; set; }

        /// <summary>
        /// 商家自定义的业务id，会记录下来，在查询消息记录列表的时候返回
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 群组id列表
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 群发消息内容模型
        /// </summary>
        [XmlElement("msg_data")]
        public GroupMessageVO MsgData { get; set; }

        /// <summary>
        /// 推送的消息文案标题（参考：好物分享来咯！）
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
