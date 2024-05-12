<template>
    <div>
        <v-card>
            <v-card-title class="font-weight-bold" style="color:#004B8D ">
                Event Card
            </v-card-title>
            <v-card-item>
                <v-row>
                    <v-col cols="12" class="pb-0">
                        <label for="eventName" class="labelText">Event Name</label><br />
                        <text-field
                            placeholder="e.g name of event"
                        ></text-field>
                    </v-col>
                    <v-col cols="6" class="pb-0">
                        <label for="StartDate" class="labelText">Start Date</label><br />
                        <text-field
                            placeholder="DD/MM/YYYY"
                        ></text-field>
                    </v-col>
                    <v-col cols="6" class="pb-0">
                        <label for="eventName" class="labelText">Event Sessions</label><br />
                        <session-diol/>
                    </v-col>
                    <v-col cols="6" class="pb-0">
                        <label for="EndDate" class="labelText">End Date</label><br />
                        <text-field
                            placeholder="DD/MM/YYYY"
                        ></text-field>
                    </v-col>
                    <v-col cols="12" class="pb-0">
                        <label for="EndDate" class="labelText">Description</label><br />
                        <v-textarea
                            row-height="20"
                            rows="2"
                            auto-grow
                            variant="solo"
                            placeholder="type your description here..."
                        ></v-textarea>
                    </v-col>
                    <v-col cols="12" class="pb-0">
                        <label for="Map" class="labelText">Map</label><br />
                        <text-field
                            placeholder="type your location"
                        ></text-field>
                    </v-col>
                    <v-col cols="6">
                        <label for="Tag" class="labelText">Tag</label><br />
                        <v-autocomplete
                            v-model="values"
                            :items="items"
                            density="compact"
                            variant="solo"
                        ></v-autocomplete>
                    </v-col>
                    <v-col cols="6">
                        <label for="Participator" class="labelText">Participator</label><br />
                        <text-field
                            placeholder="start Date"
                        ></text-field>
                    </v-col>
                    <v-col cols="12">
                        <label for="Image" class="labelText">Image</label><br />
                        <v-file-input variant="solo" density="compact" label="add image" prepend-icon=""></v-file-input>
                    </v-col>
                </v-row>
            </v-card-item>
            <v-card-actions class="d-flex justify-end">
                <v-btn variant="elevated" color="#004B8D">Discard</v-btn>
                <v-btn variant="elevated" color="#FF7F00">Post</v-btn>
            </v-card-actions>
        </v-card>
    </div>
</template>

<script>
import SessionDiol from './components/SessionDiol.vue';
import TextField from './components/TextField.vue';

export default {
    components: {
        TextField,
        SessionDiol
      },
    data: () => ({
      items: ['education', 'workshop', 'fizz', 'buzz'],
      values: 'education',
    }),
}
</script>