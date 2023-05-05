namespace WenglorWebApp
{
    public class Image
    {
        public readonly string Name;
        public string ReferencePath
        {
            get
            {
                return "images\\Reference Files\\reference_" + Name;
            }
        }

        public string ReferenceName
        {
            get
            {
                return "reference_" + Name;
            }
        }

        public string InputPath
        {
            get
            {
                return "images\\Input Files\\input_" + Name;
            }
        }

        public string OutputPath
        {
            get
            {
                return "images\\Output Files\\output_" + Name;
            }
        }

        public Image(string Name)
        {
            this.Name = Name;
        }

    }
}
