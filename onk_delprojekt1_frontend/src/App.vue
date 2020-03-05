<template>
  <v-app>
    <v-app-bar
      app
      color="primary"
      dark
    >
      <div class="d-flex align-center">
      <h1>Den bedste ONK App</h1>  

      
      </div>

      <v-spacer></v-spacer>

      <v-btn
        href="https://github.com/Berthelmaster/ONK-Delopgave-Projekt/tree/master"
        target="_blank"
        text
      >
        <span class="mr-2">Latest Release</span>
        <v-icon>mdi-open-in-new</v-icon>
      </v-btn>
    </v-app-bar>

    <v-content>
      <Frontpage/>
    </v-content>
  </v-app>
</template>

<script>
import Frontpage from './components/Frontpage';

export default {
  name: 'App',

  components: {
    Frontpage,
  },

  data: () => ({
    //
  }),
};
</script>
