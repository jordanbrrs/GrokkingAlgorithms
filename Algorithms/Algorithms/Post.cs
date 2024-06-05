namespace Algorithms
{
    internal class Post
    {
        public string PostLike(string[] names)
        {
            string display = names.Length switch
            {
                0 => "No one likes this",
                1 => $"{names[0]} likes this",
                2 => $"{names[0]} and {names[1]} like this",
                3 => $"{names[0]}, {names[1]} and {names[2]} like this",
                _ => $"{names[0]}, {names[1]} and {names.Length - 2} others like this",
            };
            return display;
        }

        public string PostLikeStringFormat(string[] names)
        {
            string[] pattern = { "no one likes this", "{0} likes this", "{0} and {1} like this", "{0}, {1} and {2} like this", "{0}, {1} and {2} others like this" };
            return names.Length < 4 ? string.Format(pattern[names.Length], names) : string.Format(pattern[4], names[0], names[1], names.Length - 2);

        }
    }
}
