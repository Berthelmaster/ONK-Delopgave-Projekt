<template>
  <v-container>
    <div class="text-center">
    <v-btn rounded color="primary buttonspace" dark>Get All Haandvaerkere</v-btn>
    <v-btn rounded color="primary buttonspace" dark>Get All Vaerktoejskasser</v-btn>
    <v-btn rounded color="primary buttonspace" dark>Get All Vaerktoejer</v-btn>
    </div>
    <div class="output text-center">
      <a class="buttonspace">Hello</a>
      <a class="buttonspace">Hello</a>
      <a class="buttonspace">Hello</a>
    </div>
    
  </v-container>
</template>

<style scoped>
.buttonspace {
  margin: 20px;
}
</style>

<script>
  export default {
    name: 'Frontpage',  
  }
</script>
