namespace SimulationTests
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void ScalarProduct()
        {
            Vector v1 = new Vector(1,1,1);
            Vector v2 = new Vector(1,1,1);

            double scalarProduct = v1 * v2;

            Assert.IsTrue(scalarProduct == 3);
        }

        [TestMethod]
        public void ScalarProductTimesScalar()
        {
            Vector v1 = new Vector(1, 1, 1);
            double scalar = 5;

            Vector result = v1 * 5;

            Assert.IsTrue(result.X == 5 && result.Y == 5 && result.Z == 5);
        }

        [TestMethod]
        public void Length()
        {
            Vector v1 = new Vector(1, 1, 1);

            double length = v1.Length;

            Assert.IsTrue(length == Math.Sqrt(1*1 + 1*1 + 1*1));
        }

        [TestMethod]
        public void Add()
        {
            Vector v1 = new Vector(1, 1, 1);
            Vector v2 = new Vector(1, 1, 1);

            Vector result = v1 + v2;

            Assert.IsTrue((result.X == v1.X + v2.X) &&
                          (result.Y == v1.Y + v2.Y) &&
                          (result.Z == v1.Z + v2.Z));
        }

        [TestMethod]
        public void Subtract()
        {
            Vector v1 = new Vector(1, 1, 1);
            Vector v2 = new Vector(1, 1, 1);

            Vector result = v1 - v2;

            Assert.IsTrue((result.X == v1.X - v2.X) &&
                          (result.Y == v1.Y - v2.Y) &&
                          (result.Z == v1.Z - v2.Z));
        }

        [TestMethod]
        public void CrossProduct()
        {
            Vector v1 = new Vector(1, 1, 1);
            Vector v2 = new Vector(1, 1, 1);

            Vector result = v1 & v2;

            Assert.IsTrue((result.X == v1.X - v2.X) &&
                          (result.Y == v1.Y - v2.Y) &&
                          (result.Z == v1.Z - v2.Z));
        }
    }
}