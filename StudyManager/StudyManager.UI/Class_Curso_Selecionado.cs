namespace StudyManager.UI
{
    public static class Class_Curso_Selecionado
    {
        public static int Curso_Id { get; set; } = 0;
        public static string Curso { get; set; } = "- Sem dados - ";
        public static string Curso_Nivel { get; set; } = "- Sem dados - ";
        public static string Curso_Status { get; set; } = "- Sem dados - ";
        public static string Curso_Data_Cadastro { get; set; } = "- Sem dados - ";

        public static void ResetarCursoSelecionado()
        {
            Curso_Id = 0;
            Curso = "- Sem dados - ";
            Curso_Nivel = "- Sem dados - ";
            Curso_Status = "- Sem dados - ";
            Curso_Data_Cadastro = "- Sem dados - ";
        }

    }
}
