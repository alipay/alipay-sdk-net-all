using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseTemplateInstanceUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseTemplateInstanceUploadModel : AopObject
    {
        /// <summary>
        /// 业务主键，唯一约束，多次重复提交时做幂等
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用于上游业务方区分不同业务
        /// </summary>
        [XmlElement("biz_key")]
        public string BizKey { get; set; }

        /// <summary>
        /// 根据身份接入申请而来的动态code
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 默认不传，如果需要区分同一个场景下的不同渠道模版，需要这个
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 可选，但一旦选择则一定按照配置id获取获取，获取不到则返回空
        /// </summary>
        [XmlElement("config_id")]
        public long ConfigId { get; set; }

        /// <summary>
        /// 指定文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fill_data")]
        [XmlArrayItem("ob_template_param_request")]
        public List<ObTemplateParamRequest> FillData { get; set; }

        /// <summary>
        /// 指定路径前缀
        /// </summary>
        [XmlElement("upload_prefix")]
        public string UploadPrefix { get; set; }
    }
}
