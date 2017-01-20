using System.Collections.Generic;

namespace SKIPSS_Service
{
    public class ResponseDocketHistotyList
    {
        public List<DocketItemActionHistoryList> docketItemActionHistoryList { get; set; }
        public string actionDate { get; set; }
        public string actionName { get; set; }
        public string applicationDate { get; set; }
        public string applicationNumber { get; set; }
        public string assistant1TKEmail { get; set; }
        public string assistant1TKID { get; set; }
        public string assistant1TKName { get; set; }
        public string assistant2TKEmail { get; set; }
        public string assistant2TKID { get; set; }
        public string assistant2TKName { get; set; }
        public string assistantTKEmail { get; set; }
        public string assistantTKID { get; set; }
        public string assistantTKName { get; set; }
        public string bookmark { get; set; }
        public string caseType { get; set; }
        public string clientName { get; set; }
        public string docketItemDeadlineDate { get; set; }
        public string docketItemDueDate { get; set; }
        public string docketItemID { get; set; }
        public string docketItemNote { get; set; }
        public string docketItemStatus { get; set; }
        public string docketItemType { get; set; }
        public string docketNumber { get; set; }
        public string docketerComments { get; set; }
        public string highlightDocket { get; set; }
        public string historyStatus { get; set; }
        public string instruction { get; set; }
        public string pointTKEmail { get; set; }
        public string pointTKID { get; set; }
        public string pointTKName { get; set; }
        public string requesterComments { get; set; }
        public string requesterName { get; set; }
        public string responsibleTKEmail { get; set; }
        public string responsibleTKID { get; set; }
        public string responsibleTKName { get; set; }
        public string selectedDate { get; set; }
        public string status { get; set; }
        public string stickNote { get; set; }
    }

    public class DocketItemActionHistoryList
    {
        public string actionDate { get; set; }
        public string docketerComments { get; set; }
        public string instruction { get; set; }
        public string requesterComments { get; set; }
        public string requesterName { get; set; }
        public string selectedDate { get; set; }
        public string status { get; set; }

    }

    public class ResponseDocketHistoty
    {
        public string status { get; set; }

        public List<ResponseDocketHistotyList> docketItemsList { get; set; }

        public string user { get; set; }
    }

    public class ResponseDocketHist
    {
        public string status { get; set; }

        public ResponseDocketHistotyList docketItem { get; set; }
    }

    public class Instructions
    {
        public string InstructionName { get; set; }

        public string InstructionId { get; set; }
    }

    public class ResponseInstructions
    {
        public List<Instructions> objList { get; set; }
        public string status { get; set; }
    }
}
