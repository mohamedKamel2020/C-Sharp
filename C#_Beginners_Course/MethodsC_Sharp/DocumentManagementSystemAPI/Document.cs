using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DocumentManagementSystemAPI
{
    public enum DocumentMetaDataFormat
    {
        JSON,
        XML,
        CSV
    }
    public abstract class Document
    {
        private readonly int _id = 0;
        private readonly string _name=String.Empty;
        private readonly string _description=String.Empty;

        private Document _leftDoc = null;
        private Document _rightDoc = null;

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; }  }
        public Document LeftDoc { get { return _leftDoc; } set { _leftDoc = value; } }
        public Document RightDoc { get { return _rightDoc; } set { _rightDoc = value; } }

        protected Document(int id)
        {
            if (IsDocIdValid(id))
            {
                _id = id;
                _name = $"Doc{_id}";
                _description = $"Doc description for document{_id}";
            }
            else
            {
                throw new Exception("Invalid Id");
            }
        }
        private bool IsValidId(int id)
        {
            if (!this.IsDocIdValid(id))
            {
                return false;
            }
            return true;
        }
        public virtual string GetSerializedDocumentMetadata(DocumentMetaDataFormat documentMetaDataFormat)
        {
            string result = null;
            switch (documentMetaDataFormat)
            {
                case DocumentMetaDataFormat.JSON:
                    throw new NotImplementedException();
                case DocumentMetaDataFormat.XML:
                    throw new NotImplementedException();
                case DocumentMetaDataFormat.CSV:
                    result = $"{Id},\"{Name}\",\"{Description}\"";
                    break;
                default:
                    throw new Exception("Invalid document metadata format");
            }
            return result;
        }

        public abstract bool IsDocIdValid(int id);
    }
}
