using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpLixinUserfillformQueryResponse.
    /// </summary>
    public class ZhimaCreditEpLixinUserfillformQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页请求时候是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 表单信息列表，列表中一个元素即为用户填写的一张表单信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("rights_form_item_values")]
        public List<RightsFormItemValues> ItemList { get; set; }

        /// <summary>
        /// 分页请求的页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 分页请求数据总计页数
        /// </summary>
        [XmlElement("page_total")]
        public long PageTotal { get; set; }

        /// <summary>
        /// 权益ID，唯一，企业信用立信平台权益说明页获取
        /// </summary>
        [XmlElement("rights_id")]
        public long RightsId { get; set; }

        /// <summary>
        /// 信用报告优惠券，有企业信用业务方自定义，在企业信用立信后台维护，不含有敏感信息
        /// </summary>
        [XmlElement("rights_name")]
        public string RightsName { get; set; }

        /// <summary>
        /// 分页请求时返回数据总量
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
