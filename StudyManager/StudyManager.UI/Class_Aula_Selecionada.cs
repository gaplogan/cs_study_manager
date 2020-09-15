namespace StudyManager.UI
{
    public static class Class_Aula_Selecionada
    {
        public static int Aula_Id { get; set; } = 0;
        public static int Curso_Id { get; set; } = 0;
        public static string Aula_Modulo { get; set; } = "- Sem dados - ";
        public static string Aula_Materia { get; set; } = "- Sem dados - ";
        public static string Aula_Titulo { get; set; } = "- Sem dados - ";
        public static string Aula_Link_1 { get; set; } = "- Sem dados - ";
        public static string Aula_Link_2 { get; set; } = "- Sem dados - ";
        public static string Aula_Data_Cadastro { get; set; } = "- Sem dados - ";

        public static void ResetarAulaSelecionada()
        {
            Class_Aula_Selecionada.Aula_Id = 0;
            Class_Aula_Selecionada.Curso_Id = 0;
            Class_Aula_Selecionada.Aula_Modulo = "- Sem dados - ";
            Class_Aula_Selecionada.Aula_Materia = "- Sem dados - ";
            Class_Aula_Selecionada.Aula_Titulo = "- Sem dados - ";
            Class_Aula_Selecionada.Aula_Link_1 = "- Sem dados - ";
            Class_Aula_Selecionada.Aula_Link_2 = "- Sem dados - ";
            Class_Aula_Selecionada.Aula_Data_Cadastro = "- Sem dados - ";
        }
    }
}
