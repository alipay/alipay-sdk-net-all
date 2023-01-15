using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanBehaviorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanBehaviorQueryModel : AopObject
    {
        /// <summary>
        /// 扩展参数，不同sceneCode下的具体说明见文档。 relationType：关系类型；objectType：客体类型；objectId：客体id；cardTemplateId：会员卡模板id
        /// </summary>
        [XmlElement("request_params")]
        public string RequestParams { get; set; }

        /// <summary>
        /// 查询场景，由棋盘注册，全局唯一。如：会员客单价区间、支付频次等。每种场景码对应不同的request_params结构
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
