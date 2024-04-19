using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthFieldApply Data Structure.
    /// </summary>
    [Serializable]
    public class AuthFieldApply : AopObject
    {
        /// <summary>
        /// 接口英文名称，通过alipay.open.app.api.query接口查询获得。
        /// </summary>
        [XmlElement("api_name")]
        public string ApiName { get; set; }

        /// <summary>
        /// 贵公司是否有自己的客服渠道，能及时响应和处理舆情数量是多少？
        /// </summary>
        [XmlElement("customer_answer")]
        public string CustomerAnswer { get; set; }

        /// <summary>
        /// 字段英文名称，通过alipay.open.app.api.query接口查询获得。
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 功能code，通过alipay.open.app.api.query接口查询获得
        /// </summary>
        [XmlElement("package_code")]
        public string PackageCode { get; set; }

        /// <summary>
        /// 接入后一年内预计接口秒级调用量峰值是多少？（最高峰值：1000QPS）
        /// </summary>
        [XmlElement("qps_answer")]
        public string QpsAnswer { get; set; }

        /// <summary>
        /// 场景code，alipay.open.app.api.scene.query 接口查询获得
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 当为使用使用模板的小程序申请时可传入所使用的小程序模板id
        /// </summary>
        [XmlElement("tiny_app_template_id")]
        public string TinyAppTemplateId { get; set; }
    }
}
