﻿namespace PizzaMore.App.Data
{
    public static class Data
    {
        private static PizzaContext context;

        public static PizzaContext Context => context ?? (context = new PizzaContext());

    }
}
