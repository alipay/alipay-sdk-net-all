using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntlescenterFileDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AntlescenterFileDTO : AopObject
    {
        /// <summary>
        /// 文件日期
        /// </summary>
        [XmlElement("file_date")]
        public string FileDate { get; set; }

        /// <summary>
        /// 文件hash
        /// </summary>
        [XmlElement("file_hash")]
        public string FileHash { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件key
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 文件md5摘要值
        /// </summary>
        [XmlElement("file_md_5")]
        public string FileMd5 { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件页数，页
        /// </summary>
        [XmlElement("file_pages")]
        public long FilePages { get; set; }

        /// <summary>
        /// 文件大小,B
        /// </summary>
        [XmlElement("file_size")]
        public string FileSize { get; set; }

        /// <summary>
        /// 文件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 印章用印信息
        /// </summary>
        [XmlArray("selected_seal_position_list")]
        [XmlArrayItem("selected_seal_position")]
        public List<SelectedSealPosition> SelectedSealPositionList { get; set; }

        /// <summary>
        /// 骑缝章用印信息
        /// </summary>
        [XmlArray("signed_cross_results")]
        [XmlArrayItem("signed_cross_result")]
        public List<SignedCrossResult> SignedCrossResults { get; set; }
    }
}
