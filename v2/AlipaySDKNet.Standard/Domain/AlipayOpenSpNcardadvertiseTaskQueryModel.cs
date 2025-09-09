using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNcardadvertiseTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNcardadvertiseTaskQueryModel : AopObject
    {
        /// <summary>
        /// c端碰一碰线圈后，是用支付宝服务可以获取到的线圈业务id
        /// </summary>
        [XmlArray("tag_id_list")]
        [XmlArrayItem("string")]
        public List<string> TagIdList { get; set; }
    }
}
