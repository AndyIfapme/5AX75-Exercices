namespace Theory_Heritage
{
    public interface IDelete
    {
        public DateTime? DeletedAt { get; set; }
        void Delete();
    }
}
