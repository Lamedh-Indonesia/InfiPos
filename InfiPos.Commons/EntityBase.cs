namespace InfiPos.Commons
{
    public class EntityBase
    {
        public int Id { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object other)
        {
            EntityBase another = (EntityBase)other;
            return Id == another.Id;
        }
    }
}
