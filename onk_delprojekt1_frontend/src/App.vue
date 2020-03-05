<template>
  <v-app>
    
    <v-app-bar
      app
      dark
    >
     <v-toolbar-items>
        <v-btn to="/">Frontpage</v-btn>
        <v-btn to="/Create">Create</v-btn>
        <v-btn to="/Delete">Delete</v-btn>
        <v-btn to="/Read">Read</v-btn>
        <v-btn to="/Update">Update</v-btn>
      </v-toolbar-items>
      
      


      
      


      
    </v-app-bar>

    <v-content>
      <router-view></router-view>
    </v-content>
  </v-app>
</template>

<script>

export default {
  name: 'App',

  components: {
    
  },

  data: () => ({
    //
  }),
};
</script>
