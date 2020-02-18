using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicTemplateMessageAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicTemplateMessageAddModel : AopObject
    {
        /// <summary>
        /// 自行组合模板关键词列表，关键词顺序按数组顺序，关键字名称不能重复，最多支持5个，最少2个关键词组合
        /// </summary>
        [XmlArray("keyword_list")]
        [XmlArrayItem("public_msg_keyword")]
        public List<PublicMsgKeyword> KeywordList { get; set; }

        /// <summary>
        /// 消息母板id，登陆生活号后台(fuwu.alipay.com)，点击菜单“模板消息”，点击“模板库”，即可看到相应模板的消息母板id
        /// </summary>
        [XmlElement("lib_code")]
        public string LibCode { get; set; }

        /// <summary>
        /// 可选字段的选择，开头语(name=first)，结束语(name=remark)以及图片(name=image)。选择使用的话则在入参中name中标识，不选用任何可选字段可不传。
        /// </summary>
        [XmlArray("opt_list")]
        [XmlArrayItem("public_msg_keyword")]
        public List<PublicMsgKeyword> OptList { get; set; }
    }
}
