namespace kata_dotnet_core_start.Lib.Tests;

public class MarsRoverTests
{
    [Theory]
    [InlineData(1, 1, 'N')]
    public void Given_starting_point_then_should(int row, int column, char direction)
    {
       // act

       var rover = new Rover(row, column, direction);

       // Assert
       Assert.Equal(new Position(row, column, direction), rover.GetPosition());
    }
}

public class Position : IEquatable<Position>
{
    private int _x;
    private int _y;
    private char _direction;

    public Position(int posX, int posY, char direction)
    {
        x x = new x(posX);
        Y y = new Y(posY);
        Facing facing = new Facing(direction);

        _x = x.GetX();
        _y = y.GetY();
        _direction = facing.GetFacing();
    }

    public bool Equals(Position? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return _x == other._x && _y == other._y && _direction == other._direction;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Position)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_x, _y, _direction);
    }
}

public class Rover
{
    private Position _position;

    public Rover(int posX, int posY, char direction)
    {
        _position = new Position(posX, posY, direction);
    }

    public Position GetPosition()
    {
        return _position;
    }
}

public class x
{
    private int _posX;

    public x(int posX)
    {
        _posX = posX;
    }

    public int GetX()
    {
        return this._posX;
    }
}

public class Y
{
    private int _posY;

    public Y(int posY)
    {
        _posY = posY;
    }

    public int GetY()
    {
        return this._posY;
    }
}

public class Facing
{
    private char _facing;

    public Facing(char facing)
    {
        _facing = facing;
    }

    public char GetFacing()
    {
        return this._facing;
    }
}
