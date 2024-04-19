using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanBoardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanBoardQueryModel : AopObject
    {
        /// <summary>
        /// 看板场景对应的请求参数
        /// </summary>
        [XmlElement("request_params")]
        public BoardQueryRequest RequestParams { get; set; }

        /// <summary>
        /// 看板场景，全局唯一 如：用户资产总览、用户资产构成、人群概览。参考：<a href="https://opendocs.alipay.com/pre-open/04phhq#%E7%9C%8B%E6%9D%BF%E5%88%86%E6%9E%90%E4%B8%8D%E5%90%8Cscene_code%E6%9F%A5%E8%AF%A2" target="_blank">不同场景码对应的查询内容</a>
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
