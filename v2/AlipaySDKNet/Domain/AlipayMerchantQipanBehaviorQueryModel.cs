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
        /// 行为分析查询，不同查询场景的查询参数，如关系类型、关系对象类型等。
        /// </summary>
        [XmlElement("request_params")]
        public BehaviorQueryRequest RequestParams { get; set; }

        /// <summary>
        /// 查询场景，由棋盘注册，全局唯一。如：会员客单价区间、支付频次等。参考：<a href="https://opendocs.alipay.com/pre-open/04phhq#%E8%A1%8C%E4%B8%BA%E5%88%86%E6%9E%90%E4%B8%8D%E5%90%8C%20scene_code%20%E6%9F%A5%E8%AF%A2" target="_blank">行为分析不同scene_code查询内容</a>
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
