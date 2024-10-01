namespace TA.Properties
{
    public class QuestionManager : MonoBehaviour
    {
        // LCM Randomizer
        private LCMRandomizer randomizer;

        // Question database
        public QuestionDatabase questionDatabase;

        // Current question index
        private int currentQuestionIndex;

        void Start()
        {
            // Create an instance of the LCMRandomizer class
            randomizer = new LCMRandomizer(1664525, 1013904223, 4294967296, 42);

            // Initialize the question database
            questionDatabase = Resources.Load<QuestionDatabase>("QuestionDatabase");

            // Set the current question index to 0
            currentQuestionIndex = 0;
        }
}