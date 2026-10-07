public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // if value == Data is not included to ignore it :)
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // return Data == value || Left != null && Left.Contains(value) || Right != null && Right.Contains(value);
        if (value < Data)
        {
            return Left != null && Left.Contains(value);
        }
        else if (value > Data)
        {
            return Right != null && Right.Contains(value);
        }
        return true;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight;

        if (Left is null)
        {
            leftHeight = 0;
        }
        else
        {
            leftHeight = Left.GetHeight();
        }

        int rightHeight;

        if (Right is null)
        {
            rightHeight = 0;
        }
        else
        {
            rightHeight = Right.GetHeight();
        }

        return 1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }
}