using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatFileQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatFileQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的文件列表
        /// </summary>
        [XmlElement("data")]
        public FileBriefInfo Data { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 上传的文件的总的个数，单位：个
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }

        /// <summary>
        /// 上传的所有文件，按照当前分页标准，一共有多少页。单位：页
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
