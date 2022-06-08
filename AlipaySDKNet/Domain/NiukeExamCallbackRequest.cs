using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NiukeExamCallbackRequest Data Structure.
    /// </summary>
    [Serializable]
    public class NiukeExamCallbackRequest : AopObject
    {
        /// <summary>
        /// 考生具体每一类题型的得分情况。这个参数会有多个，每一个的参数格式是score|categoryId|categoryName 如1.5|100|选择题。
        /// </summary>
        [XmlArray("category_scores")]
        [XmlArrayItem("string")]
        public List<string> CategoryScores { get; set; }

        /// <summary>
        /// true、false 是否作弊，疑似作弊时为null
        /// </summary>
        [XmlElement("is_cheated")]
        public string IsCheated { get; set; }

        /// <summary>
        /// 唯一id，即应聘id
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 试卷id
        /// </summary>
        [XmlElement("paper_id")]
        public string PaperId { get; set; }

        /// <summary>
        /// 试卷名称
        /// </summary>
        [XmlElement("paper_name")]
        public string PaperName { get; set; }

        /// <summary>
        /// 试卷满分
        /// </summary>
        [XmlElement("paper_score")]
        public long PaperScore { get; set; }

        /// <summary>
        /// 测评成绩报告的PDF的URL
        /// </summary>
        [XmlElement("result_pdf_url")]
        public string ResultPdfUrl { get; set; }

        /// <summary>
        /// 考生试卷总得分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 测评的状态 NOT_DO-未做题,DOING-正在做题,DONE-做完题,JUDGED-人工阅卷完成, CHEAT_DETECT_DONE-作弊检测完成，DELETE-删除
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 考生交卷时间(毫秒级时间戳)
        /// </summary>
        [XmlElement("test_finish_time")]
        public long TestFinishTime { get; set; }

        /// <summary>
        /// 考生考试开始时间(毫秒级时间戳)
        /// </summary>
        [XmlElement("test_start_time")]
        public long TestStartTime { get; set; }
    }
}
