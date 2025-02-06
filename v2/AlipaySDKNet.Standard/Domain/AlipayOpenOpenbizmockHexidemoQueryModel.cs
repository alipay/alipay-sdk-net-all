using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOpenbizmockHexidemoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOpenbizmockHexidemoQueryModel : AopObject
    {
        /// <summary>
        /// 复杂接口的类型
        /// </summary>
        [XmlElement("child_nodes")]
        public JsonParamDemo ChildNodes { get; set; }

        /// <summary>
        /// 文件内容
        /// </summary>
        [XmlElement("file_param")]
        public string FileParam { get; set; }

        /// <summary>
        /// 测试名称
        /// </summary>
        [XmlElement("mock_name")]
        public string MockName { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("other_open_id")]
        public string OtherOpenId { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [XmlElement("other_user_id")]
        public string OtherUserId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlArray("out_biz_no")]
        [XmlArrayItem("string")]
        public List<string> OutBizNo { get; set; }

        /// <summary>
        /// 布尔值示例
        /// </summary>
        [XmlElement("pattern_param")]
        public string PatternParam { get; set; }

        /// <summary>
        /// 请输入数字
        /// </summary>
        [XmlElement("req_num")]
        public long ReqNum { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("res")]
        public string Res { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
