using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupConfigModelConfig Data Structure.
    /// </summary>
    [Serializable]
    public class GroupConfigModelConfig : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("check_condition")]
        [XmlArrayItem("string")]
        public List<string> CheckCondition { get; set; }

        /// <summary>
        /// 碰一下开门是否需要阻断检查，非阻断情况降级走手机号
        /// </summary>
        [XmlElement("need_block_check")]
        public bool NeedBlockCheck { get; set; }

        /// <summary>
        /// 默认手机号-MOBILE 会员id-MEMBER_ID 支付宝openid-OPEN_ID
        /// </summary>
        [XmlElement("user_relate_type")]
        public string UserRelateType { get; set; }
    }
}
